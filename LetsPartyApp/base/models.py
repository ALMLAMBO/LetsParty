from django.contrib.auth.models import User
from django.core.validators import MinValueValidator
from django.db import models


class List(models.Model):
    name = models.CharField(max_length=100, blank=False)
    owner = models.ForeignKey(User, on_delete=models.CASCADE)

    def __str__(self):
        return self.name


class Location(models.Model):
    location = models.CharField(max_length=100, blank=False)
    list_id = models.ForeignKey(List, on_delete=models.CASCADE)

    def __str__(self):
        return self.location


class Game(models.Model):
    name = models.CharField(max_length=100, blank=False)
    description = models.CharField(max_length=255, blank=False)
    number_of_players = models.IntegerField(blank=False)
    duration = models.CharField(max_length=100)
    fetch_by = models.ForeignKey(User, on_delete=models.SET_DEFAULT, blank=True, null=True, default=None)
    list_id = models.ForeignKey(List, on_delete=models.CASCADE)

    def __str__(self):
        return self.name


class Items(models.Model):
    name = models.CharField(max_length=100, blank=False)
    price = models.DecimalField(blank=True, default=0, decimal_places=2, max_digits=5)
    bought = models.BooleanField(blank=False, default=False)
    quantity = models.IntegerField(default=1, validators=[MinValueValidator(1)])
    fetch_by = models.ForeignKey(User, on_delete=models.SET_DEFAULT, blank=True, null=True, default=None)
    list_id = models.ForeignKey(List, on_delete=models.CASCADE)

    def __str__(self):
        return self.name


class Party(models.Model):
    name = models.CharField(max_length=100, blank=False)
    description = models.CharField(max_length=255, blank=True, default='')
    created_at = models.DateTimeField(auto_now_add=True)
    owner = models.ForeignKey(User, on_delete=models.CASCADE)

    privacy = models.BooleanField(default=False)
    beginning = models.DateTimeField(blank=False)
    duration = models.CharField(max_length=100, blank=False)

    guests = models.ManyToManyField(User, related_name='guest_list', default=None)
    limit = models.IntegerField(blank=True)

    locations = models.ForeignKey(List, on_delete=models.SET_DEFAULT, default=None, related_name='locations_list', blank=True, null=True)
    games = models.ForeignKey(List, on_delete=models.SET_DEFAULT, default=None, related_name='game_list', blank=True, null=True)
    items = models.ForeignKey(List, on_delete=models.SET_DEFAULT, default=None, related_name='items_list', blank=True, null=True)
    playlist = models.CharField(max_length=255, blank=True, default='')

    def __str__(self):
        return self.name
