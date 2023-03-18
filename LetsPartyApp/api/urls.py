from django.urls import path, include
from . import views

urlpatterns = [
    path('', views.get_all_party),
    path('accounts/', include('rest_registration.api.urls')),
    path('games', views.get_games),
    path('add_game/', views.create_game)
]