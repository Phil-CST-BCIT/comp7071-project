from connexion import NoContent, FlaskApp
import logging.config
import yaml
from pymongo import MongoClient

def get_all_applicants():
    logger.info(f"Request: get_all_applicants")
    applicant_c = db['applicant']
    res = []
    for a in applicant_c.find():
        res.append(
            {
                'id': a['id'],
                'name': a['name'],
                'employer': a['employer'],
                'income': a['income'],
                'reference': a['reference'],
            }
        )
    return res, 200

def create_applicant(body):
    # db = get_database()
    logger.info(f"Request: create_applicant: {body}")
    applicant_c = db['applicant']
    applicant_c.insert_one(body)
    return NoContent, 201

def get_applicant_by_id(id):
    logger.info(f"Request: get_applicant_by_id: {id}")
    applicant_c = db['applicant']
    found = applicant_c.find_one({'id': id})
    status = 404
    res = {"message": f"Applicant not found, id: {id}"}

    if found:
        res = {
                'id': found['id'],
                'name': found['name'],
                'employer': found['employer'],
                'income': found['income'],
                'reference': found['reference'],
            }
        status = 200
    return res, status
    
def update_applicant_by_id(id, body):
    logger.info(f"Request: update_applicant_by_id: {id}, {body}")
    applicant_c = db['applicant']
    res = applicant_c.update_one({'id': id}, {'$set': body})
    status = 404
    if res.modified_count == 1:
        status = 200
    else:
        res = {"message": f"Applicant not found, id: {id}"}
    return res, status

def delete_applicant_by_id(id):
    logger.info(f"Request: delete_applicant_by_id: {id}")
    applicant_c = db['applicant']
    
    applicant_c.delete_one({'id': id})
    return NoContent, 204

def get_all_assets():
    logger.info(f"Request: get_all_assets")
    asset_c = db['asset']
    res = []
    for a in asset_c.find():
        res.append(
            {
                'id': a['id'],
                'asset_type': a['asset_type'],
                'status': a['status'],
                'location': a['location'],
                'occupancy_history': a['occupancy_history'],
                'rent_history': a['rent_history'],
                'damage_history': a['damage_history'],
                'appliances': a['appliances'],
            }
        )
    return res, 200

def create_asset(body):
    # db = get_database()
    logger.info(f"Request: create_asset: {body}")
    asset_c = db['asset']
    asset_c.insert_one(body)
    return NoContent, 201

def get_asset_by_id(id):
    logger.info(f"Request: get_asset_by_id: {id}")
    asset_c = db['asset']
    found = asset_c.find_one({'id': id})
    status = 404
    res = {"message": f"Asset not found, id: {id}"}

    if found:
        res = {
                'id': found['id'],
                'asset_type': found['asset_type'],
                'status': found['status'],
                'location': found['location'],
                'occupancy_history': found['occupancy_history'],
                'rent_history': found['rent_history'],
                'damage_history': found['damage_history'],
                'appliances': found['appliances'],
            }
        status = 200
    return res, status

def update_asset_by_id(id, body):
    logger.info(f"Request: update_asset_by_id: {id}, {body}")
    asset_c = db['asset']
    res = asset_c.update_one({'id': id}, {'$set': body})
    status = 404
    if res.modified_count == 1:
        status = 200
    else:
        res = {"message": f"Applicant not found, id: {id}"}
    return res, status
    

def get_database():
 
   # Provide the mongodb atlas url to connect python to mongodb using pymongo
   connection_str = f"mongodb://{app_config['datastore']['user']}:{app_config['datastore']['password']}@{app_config['datastore']['hostname']}/?authSource={app_config['datastore']['authSource']}"
   logger.info(f"Connecting to: {connection_str}")
   # Create a connection using MongoClient. You can import MongoClient or use pymongo.MongoClient
   client = MongoClient(connection_str)
 
   # Create the database for our example (we will use the same database throughout the tutorial
   return client['crm-db']
  
app_conf_file = "app_conf.yml"
log_conf_file = "log_conf.yml"

with open(app_conf_file, 'r') as f:
    app_config = yaml.safe_load(f.read())

with open(log_conf_file, 'r') as f:
    log_config = yaml.safe_load(f.read())
    logging.config.dictConfig(log_config)

logger = logging.getLogger('basicLogger')

logger.info(f"App Conf File: {app_conf_file}")
logger.info(f"Log Conf File: {log_conf_file}")

db = get_database()

app = FlaskApp(__name__, specification_dir='')
app.add_api("openapi.yml", strict_validation=True, validate_responses=True)

if __name__ == "__main__":
    logger.info(f"Running App")

    app.run(host='0.0.0.0',port=8100)
