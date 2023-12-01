import random
import json
from faker import Faker
import json

fake = Faker()

def generate_asset_sample_data():
    r_asset_type = fake.random_element(elements=('parking-spot', 'apartment', 'house'))
    data = {
        "id": random.randint(1, 100),
        "asset_type": r_asset_type,
        "status": fake.random_element(elements=('available', 'rented', 'damaged')),
        "location": fake.address(),
        "occupance_history": [{
            "id": random.randint(1, 100),
            "start_date": fake.date(),
            "end_date": fake.date(),
            "license_plate": fake.license_plate() if r_asset_type == "parking-spot" else "N/A",
        } for _ in range(10)],
        "rent_history": [{
            "id": random.randint(1, 100),
            "change_date": fake.date(),
            "amount": round(random.uniform(100, 2000), 2),
        } for _ in range(3)],
        "damage_history": [{
            "id": random.randint(1, 100),
            "description": fake.text(max_nb_chars=100),
            "date_reported": fake.date(),
        } for _ in range(5)],
        "appliances": [{
            "id": random.randint(1, 100),
            "brand": fake.company(),
            "model": fake.random_element(elements=('Model X', 'Model Y', 'Model Z')),
        } for _ in range(5)]
    }
    return data

def generate_applicant_sample_data(asset_ids):
    applicant = {
        "id": random.randint(1, 1000),
        "name": fake.name(),
        "employer": fake.company(),
        "income": round(random.uniform(1000, 10000), 2),
        "asset_id": fake.random_element(elements=asset_ids),
        "reference": {
            "id": random.randint(1, 1000),
            "name": fake.name(),
            "relationship": fake.random_element(elements=('friend', 'family', 'colleague')),
        },
    }
    return applicant

if __name__ == "__main__":
    records = [generate_asset_sample_data() for _ in range(10)]
    ids = [r['id'] for r in records]

    # print(records)

    fname = "./test/sample_asset_data.json"
    with open(fname, "w") as file:
        json.dump(records, file, indent=4)

    records = [generate_applicant_sample_data(ids) for _ in range(10)]
    fname = "./test/sample_applicant_data.json"
    with open(fname, "w") as file:
        json.dump(records, file, indent=4)
