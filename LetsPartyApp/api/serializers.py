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
    description = serializers.CharField(required=False)
    guests = serializers.PrimaryKeyRelatedField(many=True, queryset=User.objects.all())
    locations = serializers.PrimaryKeyRelatedField(many=True, read_only=False, queryset=Location.objects.all())
    games = serializers.PrimaryKeyRelatedField(many=True, read_only=False, required=False, queryset=Game.objects.all())
    items = serializers.PrimaryKeyRelatedField(many=True, read_only=False, required=False, queryset=Items.objects.all())
    id = serializers.IntegerField(required=False)

    class Meta:
        model = Party
        fields = ('id', 'name', 'description', 'created_at', 'owner', 'privacy', 'is_home_party',
                  'beginning', 'duration', 'guests', 'limit', 'locations', 'games', 'items', 'playlist')
        read_only_fields = ('id', )

    def to_representation(self, instance):
        representation = super().to_representation(instance)
        representation['number_of_guests'] = instance.guests.count()

        return representation

