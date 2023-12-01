import json
import requests

if __name__ == "__main__":
    endpoint_url = "http://localhost:8100/asset"

    with open("./test/sample_asset_data.json") as file:
        data = json.load(file)

    for record in data:
        response = requests.post(endpoint_url, json=record)

        if response.status_code == 201:
            print("POST request successful")
        else:
            print("POST request failed")


    endpoint_url = "http://localhost:8100/applicant"

    with open("./test/sample_applicant_data.json") as file:
        data = json.load(file)

    for record in data:
        response = requests.post(endpoint_url, json=record)

        if response.status_code == 201:
            print("POST request successful")
        else:
            print("POST request failed")
