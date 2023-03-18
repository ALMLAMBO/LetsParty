from django.urls import path, include
from . import views

urlpatterns = [
    path('', views.get_all_party),
    path('accounts/', include('rest_registration.api.urls')),
    path('games', views.get_games),
    path('add_game/', views.create_game),
    path('game/<int:game_id>/', views.get_game),
    path('update_game/<int:game_id>/', views.update_game),
    path('delete_game/<int:game_id>/', views.delete_game),

]