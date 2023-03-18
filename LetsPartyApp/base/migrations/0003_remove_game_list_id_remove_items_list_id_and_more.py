# Generated by Django 4.1.7 on 2023-03-18 14:08

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('base', '0002_party_is_home_party'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='game',
            name='list_id',
        ),
        migrations.RemoveField(
            model_name='items',
            name='list_id',
        ),
        migrations.RemoveField(
            model_name='location',
            name='list_id',
        ),
        migrations.RemoveField(
            model_name='party',
            name='games',
        ),
        migrations.RemoveField(
            model_name='party',
            name='items',
        ),
        migrations.RemoveField(
            model_name='party',
            name='locations',
        ),
        migrations.DeleteModel(
            name='List',
        ),
        migrations.AddField(
            model_name='party',
            name='games',
            field=models.ManyToManyField(default=None, related_name='game_list', to='base.game'),
        ),
        migrations.AddField(
            model_name='party',
            name='items',
            field=models.ManyToManyField(default=None, related_name='items_list', to='base.items'),
        ),
        migrations.AddField(
            model_name='party',
            name='locations',
            field=models.ManyToManyField(default=None, related_name='locations_list', to='base.location'),
        ),
    ]
