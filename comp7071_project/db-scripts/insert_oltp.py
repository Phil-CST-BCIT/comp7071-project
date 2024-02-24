import random
import json
import requests

from random_data import (
    random_id,
    random_asset,
    random_appliance,
    random_applicant,
    random_application,
    random_damage,
    random_invoice,
    random_job_report,
)

base_url = "http://localhost:5113/api/"
auth_token = "e217954a-a1f6-4896-a847-a055d7dde399"  # Replace with your actual authorization token


def post_request(endpoint, payload):
    url = base_url + endpoint
    headers = {
        "Authorization": f"Bearer {auth_token}",
        "Content-Type": "application/json",
    }
    response = requests.post(url, json=payload, headers=headers)
    return response


def post_records(endpoint, records):
    ids = []
    for record in records:
        response = post_request(endpoint, record)
        print(response.request.url, response.status_code)
        if response.status_code == 201:
            ids.append(response.json()["id"])
        elif response.status_code == 400:
            print(response.reason)

    return ids


if __name__ == "__main__":
    data_dir = "./data"

    assets = [random_asset() for _ in range(10)]

    asset_ids = post_records("asset", assets)

    appliances = [random_appliance(random_id(asset_ids)) for _ in range(10)]

    appliance_ids = post_records("appliance", appliances)
