import json
import requests

# Define the endpoint URL
endpoint_url = "http://localhost:8100/asset"

# Open the JSON file
with open("./test/sample_asset_data.json") as file:
    data = json.load(file)

# Iterate over each record in the JSON data
for record in data:
    # Make a POST request with the record to the endpoint
    response = requests.post(endpoint_url, json=record)

    # Check the response status code
    if response.status_code == 201:
        print("POST request successful")
    else:
        print("POST request failed")
