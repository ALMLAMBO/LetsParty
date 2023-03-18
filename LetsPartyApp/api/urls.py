from django.urls import path, include
from . import views

urlpatterns = [
    path('', views.get_test_party),
    path('accounts/', include('rest_registration.api.urls')),
]