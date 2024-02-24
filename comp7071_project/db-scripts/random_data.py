# Description: This file contains the functions to generate random data
from faker import Faker

fake = Faker()


def random_id(ids):
    return fake.random_element(elements=ids)

def record_ids(model_list):
    return [model["id"] for model in model_list]

def random_record_id(model_list):
    return random_id(record_ids(model_list))

def random_appliance(asset_id):
    appliance = {
        "make": fake.company(),
        "model": fake.word(),
        "assetId": asset_id,
    }
    return appliance

def random_applicant():
    applicant = {
        "name": fake.name(),
        "employer": fake.company(),
        "income": fake.random_number(digits=5)
    }
    return applicant


def random_application(applicant_id, asset_id):
    application = {
        "applicantId": applicant_id,
        "assetId": asset_id
    }
    return application

def random_asset():
    asset = {
        "type": fake.word(),
        "status": fake.random_int(min=0, max=2),
        "location": fake.address()
    }
    return asset

def random_damage(asset_id):
    damage = {
        "description": fake.sentence(),
        "dateReported": fake.date(),
        "assetId": asset_id
    }
    return damage

def random_invoice(renter_id):
    invoice = {
        "paymentAmount": fake.random_number(digits=4),
        "tax": fake.random_number(digits=2),
        "dueDate": fake.date(),
        "renterID": renter_id
    }
    return invoice

def random_job_report(maintenance_request_id):
    job_report = {
        "description": fake.sentence(),
        "dateCompleted": fake.date(),
        "maintenanceRequestId": maintenance_request_id
    }
    return job_report

def random_line_item(invoice_id, service_id):
    line_item = {
        "hours": fake.random_int(min=1, max=10),
        "invoiceId": invoice_id,
        "serviceId": service_id
    }
    return line_item

def random_maintenance_request(appliance_id, renter_id):
    maintenance_request = {
        "date": fake.date(),
        "description": fake.sentence(),
        "applianceId": appliance_id,
        "renterId": renter_id
    }
    return maintenance_request

def random_occupancy_history():
    occupancy_history = {
        "startDate": fake.name(),
        "endDate": fake.email(),
        "licensePlate": fake.license_plate()
    }
    return occupancy_history

def random_reference():
    reference = {
        "name": fake.name(),
        "email": fake.email()
    }
    return reference

def random_renter():
    renter = {
        "name": fake.name(),
        "income": fake.random_number(digits=5),
        "emergencyContactEmail": fake.email(),
        "familyDoctorEmail": fake.email()
    }
    return renter

def random_rent_history(asset_id):
    rent_history = {
        "effectiveDate": fake.date(),
        "amount": fake.random_number(digits=4),
        "assetId": asset_id
    }
    return rent_history

def random_service():
    service = {
        "type": fake.word(),
        "rate": fake.random_number(digits=2)
    }
    return service