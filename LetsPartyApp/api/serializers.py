from django.contrib.auth import authenticate
from django.contrib.auth.models import User
from rest_framework import serializers
from base.models import Game, Items, Location, Party


class LocationSerialization(serializers.ModelSerializer):
    class Meta:
        model = Location
        fields = '__all__'


class GameSerialization(serializers.ModelSerializer):
    fetch_by = serializers.HiddenField(default=serializers.CurrentUserDefault())
    description = serializers.CharField(required=False)
    id = serializers.IntegerField(required=False)

    class Meta:
        model = Game
        fields = ('id', 'name', 'description', 'number_of_players', 'duration', 'fetch_by')
        read_only_fields = ('id',)

'''
class ItemsSerialization(serializers.ModelSerializer):
    fetch_by = serializers.HiddenField(required=False)

    class Meta:
        model = Items
        fields = ('id', 'name', 'price', 'brought', 'quantity', 'fetch_by')
        read_only_fields = ('id',)

'''
class PartySerialization(serializers.ModelSerializer):
    owner = serializers.HiddenField(default=serializers.CurrentUserDefault())

    class Meta:
        model = Party
        fields = '__all__'