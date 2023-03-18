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
    path('locations', views.get_locations),
    path('add_location/', views.create_location),
    path('location/<int:loc_id>/', views.get_location),
    path('update_location/<int:loc_id>/', views.update_location),
    path('delete_location/<int:loc_id>/', views.delete_location),
    path('items', views.get_items),
    path('add_item/', views.create_item),
    path('item/<int:item_id>/', views.get_item),
    path('update_item/<int:item_id>/', views.update_item),
    path('delete_item/<int:item_id>/', views.delete_item),
]