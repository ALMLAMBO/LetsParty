from django.contrib.auth import authenticate
from django.contrib.auth.models import User
from django.db.models import SET_NULL
from rest_framework import serializers
from base.models import Game, Items, Location, Party


class LocationSerialization(serializers.ModelSerializer):
    id = serializers.IntegerField(required=False)

    class Meta:
        model = Location
        fields = '__all__'
        read_only_fields = ('id',)


class GameSerialization(serializers.ModelSerializer):
    fetch_by = serializers.PrimaryKeyRelatedField(default=serializers.CurrentUserDefault(), queryset=User.objects.all())

    description = serializers.CharField(required=False)
    id = serializers.IntegerField(required=False)

    class Meta:
        model = Game
        fields = ('id', 'name', 'description', 'number_of_players', 'duration', 'fetch_by')
        read_only_fields = ('id',)


class ItemsSerialization(serializers.ModelSerializer):
    fetch_by = serializers.PrimaryKeyRelatedField(default=serializers.CurrentUserDefault(), queryset=User.objects.all())
    bought = serializers.BooleanField(required=False, default=False)

    class Meta:
        model = Items
        fields = ('id', 'name', 'price', 'bought', 'quantity', 'fetch_by')
        read_only_fields = ('id',)


class PartySerialization(serializers.ModelSerializer):
    owner = serializers.PrimaryKeyRelatedField(default=serializers.CurrentUserDefault(), queryset=User.objects.all())

    class Meta:
        model = Party
        fields = '__all__'
