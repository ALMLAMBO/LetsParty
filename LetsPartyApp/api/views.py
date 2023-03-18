from rest_framework.response import Response
from rest_framework.decorators import api_view


@api_view(['GET'])
def get_test_party(request):
    party = {'name': 'party #0', 'privacy': 0}
    return Response(party)
