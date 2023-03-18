from rest_framework import status
from rest_framework.generics import get_object_or_404
from rest_framework.response import Response
from rest_framework.decorators import api_view
from base.models import Items, Game, Location, Party
from .serializers import PartySerialization, GameSerialization


@api_view(['GET'])
def get_all_party(request):
    parties = Party.objects.all()
    serializer = PartySerialization(parties, many=True)
    return Response(serializer.data)


@api_view(['GET'])
def get_games(request):
    games = Game.objects.all()
    serializer = GameSerialization(games, many=True)
    return Response(serializer.data)


@api_view(['GET'])
def get_game(request, game_id):
    try:
        game = Game.objects.get(id=game_id)
    except Game.DoesNotExist:
        return Response({'error': 'Game not found'}, status=status.HTTP_404_NOT_FOUND)
    serializer = GameSerialization(game, many=False)
    return Response(serializer.data)


@api_view(['POST'])
def create_game(request):
    serializer = GameSerialization(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
    return Response(serializer.data)


@api_view(['PUT'])
def update_game(request, game_id):
    try:
        game = Game.objects.get(id=game_id)
    except Game.DoesNotExist:
        return Response({'error': 'Game not found'}, status=status.HTTP_404_NOT_FOUND)

    serializer = GameSerialization(game, data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['DELETE'])
def delete_game(request, game_id):
    game = get_object_or_404(Game, pk=game_id)
    game.delete()
    return Response(status=status.HTTP_202_ACCEPTED)
