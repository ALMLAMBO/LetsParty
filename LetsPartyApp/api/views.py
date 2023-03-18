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


@api_view(['POST'])
def create_game(request):
    serializer = GameSerialization(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
    return Response(serializer.data)
