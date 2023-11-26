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
            }
        )
    return res, 200

def create_applicant(body):
    # db = get_database()
    logger.info(f"Request: create_applicant: {body}")
    applicant_c = db['applicant']
    applicant_c.insert_one(body)
    return NoContent, 201

def get_database():
 
   # Provide the mongodb atlas url to connect python to mongodb using pymongo
   connection_str = f"mongodb://{app_config['datastore']['user']}:{app_config['datastore']['password']}@{app_config['datastore']['hostname']}/?authSource={app_config['datastore']['authSource']}"
 
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
    app.run(host='0.0.0.0',port=8100)
