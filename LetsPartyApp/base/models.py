from django.contrib.auth.models import User
from django.core.validators import MinValueValidator
from django.db import models


class Location(models.Model):
    location = models.CharField(max_length=100, blank=False)

    def __str__(self):
        return self.location


class Game(models.Model):
    name = models.CharField(max_length=100, blank=False)
    description = models.CharField(max_length=255, blank=False)
    number_of_players = models.IntegerField(blank=False)
    duration = models.CharField(max_length=100)
    fetch_by = models.ForeignKey(User, on_delete=models.CASCADE)

    def __str__(self):
        return self.name


class Items(models.Model):
    name = models.CharField(max_length=100, blank=False)
    price = models.DecimalField(blank=True, default=0, decimal_places=2, max_digits=5)
    bought = models.BooleanField(blank=True, default=False)
    quantity = models.IntegerField(default=1, validators=[MinValueValidator(1)])
    fetch_by = models.ForeignKey(User, on_delete=models.SET_NULL, blank=True, null=True)

    def __str__(self):
        return self.name

    def save(self, *args, **kwargs):
        if self.bought and not self.fetch_by:
            self.fetch_by = self._meta.model.fetch_by.field.default(self)
        elif not self.bought:
            self.fetch_by = None
        super().save(*args, **kwargs)


class Party(models.Model):
    name = models.CharField(max_length=100, blank=False)
    description = models.CharField(max_length=255, blank=True, default='')
    created_at = models.DateTimeField(auto_now_add=True)
    owner = models.ForeignKey(User, on_delete=models.CASCADE)

    privacy = models.BooleanField(default=False)
    is_home_party = models.BooleanField(default=False)
    beginning = models.DateTimeField(blank=False)
    duration = models.CharField(max_length=100, blank=False)

    guests = models.ManyToManyField(User, related_name='guest_list', default=None)
    limit = models.IntegerField(blank=True)

    locations = models.ManyToManyField(Location, default=None, related_name='locations_list')
    games = models.ManyToManyField(Game, default=None, related_name='game_list')
    items = models.ManyToManyField(Items, default=None, related_name='items_list')
    playlist = models.CharField(max_length=255, blank=True, default='')

    def __str__(self):
        return self.name
