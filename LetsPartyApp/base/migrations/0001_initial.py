

from django.conf import settings
import django.core.validators
from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    initial = True

    dependencies = [
        migrations.swappable_dependency(settings.AUTH_USER_MODEL),
    ]

    operations = [
        migrations.CreateModel(
            name='List',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
                ('owner', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL)),
            ],
        ),
        migrations.CreateModel(
            name='Party',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
                ('description', models.CharField(blank=True, default='', max_length=255)),
                ('created_at', models.DateTimeField(auto_now_add=True)),
                ('privacy', models.BooleanField(default=False)),
                ('beginning', models.DateTimeField()),
                ('duration', models.CharField(max_length=100)),
                ('limit', models.IntegerField(blank=True)),
                ('playlist', models.CharField(blank=True, default='', max_length=255)),
                ('games', models.ForeignKey(blank=True, default=None, null=True, on_delete=django.db.models.deletion.SET_DEFAULT, related_name='game_list', to='base.list')),
                ('guests', models.ManyToManyField(default=None, related_name='guest_list', to=settings.AUTH_USER_MODEL)),
                ('items', models.ForeignKey(blank=True, default=None, null=True, on_delete=django.db.models.deletion.SET_DEFAULT, related_name='items_list', to='base.list')),
                ('locations', models.ForeignKey(blank=True, default=None, null=True, on_delete=django.db.models.deletion.SET_DEFAULT, related_name='locations_list', to='base.list')),
                ('owner', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to=settings.AUTH_USER_MODEL)),
            ],
        ),
        migrations.CreateModel(
            name='Location',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('location', models.CharField(max_length=100)),
                ('list_id', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='base.list')),
            ],
        ),
        migrations.CreateModel(
            name='Items',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
                ('price', models.DecimalField(blank=True, decimal_places=2, default=0, max_digits=5)),
                ('bought', models.BooleanField(default=False)),
                ('quantity', models.IntegerField(default=1, validators=[django.core.validators.MinValueValidator(1)])),
                ('fetch_by', models.ForeignKey(blank=True, default=None, null=True, on_delete=django.db.models.deletion.SET_DEFAULT, to=settings.AUTH_USER_MODEL)),
                ('list_id', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='base.list')),
            ],
        ),
        migrations.CreateModel(
            name='Game',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=100)),
                ('description', models.CharField(max_length=255)),
                ('number_of_players', models.IntegerField()),
                ('duration', models.CharField(max_length=100)),
                ('fetch_by', models.ForeignKey(blank=True, default=None, null=True, on_delete=django.db.models.deletion.SET_DEFAULT, to=settings.AUTH_USER_MODEL)),
                ('list_id', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='base.list')),
            ],
        ),
    ]
