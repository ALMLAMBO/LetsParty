from rest_framework import status
from rest_framework.generics import get_object_or_404
from rest_framework.response import Response
from rest_framework.decorators import api_view
from base.models import Items, Game, Location, Party
from .serializers import PartySerialization, GameSerialization, LocationSerialization, ItemsSerialization


@api_view(['GET'])
def get_all_party(request):
    parties = Party.objects.all()
    serializer = PartySerialization(parties, many=True)
    return Response(serializer.data)


@api_view(['POST'])
def create_party(request):
    serializer = PartySerialization(data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['PUT'])
def update_party(request, party_id):
    try:
        game = Party.objects.get(id=party_id)
    except Party.DoesNotExist:
        return Response({'error': 'Party not found'}, status=status.HTTP_404_NOT_FOUND)

    serializer = PartySerialization(game, data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['GET'])
def get_party(request, party_id):
    try:
        party = Party.objects.get(id=party_id)
    except Party.DoesNotExist:
        return Response({'error': 'Party not found'}, status=status.HTTP_404_NOT_FOUND)
    serializer = PartySerialization(party, many=False)
    return Response(serializer.data)


@api_view(['PUT'])
def update_party(request, party_id):
    try:
        party = Party.objects.get(id=party_id)
    except Party.DoesNotExist:
        return Response({'error': 'Party not found'}, status=status.HTTP_404_NOT_FOUND)

    serializer = PartySerialization(party, data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)

@api_view(['DELETE'])
def delete_party(request, party_id):
    party = get_object_or_404(Party, pk=party_id)
    party.delete()
    return Response(status=status.HTTP_202_ACCEPTED)


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


@api_view(['GET'])
def get_locations(request):
    locations = Location.objects.all()
    serializer = LocationSerialization(locations, many=True)
    return Response(serializer.data)


@api_view(['GET'])
def get_location(request, loc_id):
    try:
        location = Game.objects.get(id=loc_id)
    except Location.DoesNotExist:
        return Response({'error': 'Location not found'}, status=status.HTTP_404_NOT_FOUND)
    serializer = LocationSerialization(location, many=False)
    return Response(serializer.data)


@api_view(['POST'])
def create_location(request):
    serializer = LocationSerialization(data=request.data)
    if serializer.is_valid():
        serializer.save()
    return Response(serializer.data)


@api_view(['PUT'])
def update_location(request, loc_id):
    try:
        location = Location.objects.get(id=loc_id)
    except Location.DoesNotExist:
        return Response({'error': 'Location not found'}, status=status.HTTP_404_NOT_FOUND)

    serializer = LocationSerialization(location, data=request.data)
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['DELETE'])
def delete_location(request, loc_id):
    location = get_object_or_404(Game, pk=loc_id)
    location.delete()
    return Response(status=status.HTTP_202_ACCEPTED)


@api_view(['GET'])
def get_items(request):
    items = Items.objects.all()
    serializer = ItemsSerialization(items, many=True)
    return Response(serializer.data)


@api_view(['GET'])
def get_item(request, item_id):
    try:
        item = Items.objects.get(id=item_id)
    except Location.DoesNotExist:
        return Response({'error': 'Item not found'}, status=status.HTTP_404_NOT_FOUND)
    serializer = ItemsSerialization(item, many=False)
    return Response(serializer.data)


@api_view(['POST'])
def create_item(request):
    serializer = ItemsSerialization(data=request.data)
    if serializer.is_valid():
        serializer.save()
    return Response(serializer.data)


@api_view(['PUT'])
def update_item(request, item_id):
    try:
        item = Items.objects.get(id=item_id)
    except Items.DoesNotExist:
        return Response({'error': 'Item not found'}, status=status.HTTP_404_NOT_FOUND)

    serializer = ItemsSerialization(item, data=request.data, context={'request': request})
    if serializer.is_valid():
        serializer.save()
        return Response(serializer.data)
    return Response(serializer.errors, status=status.HTTP_400_BAD_REQUEST)


@api_view(['DELETE'])
def delete_item(request, item_id):
    item = get_object_or_404(Game, pk=item_id)
    item.delete()
    return Response(status=status.HTTP_202_ACCEPTED)
