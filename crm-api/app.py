import connexion
import logging.config
import yaml
import requests
from datetime import datetime
from flask_cors import CORS, cross_origin
from pymongo import MongoClient
import os


def getAllApplicants(body):
    pass

def getApplicantDetails(body):
    pass

def createApplicant(body):
    applicant_c = db['applicant']
    applicant_c.insert_one(body)

def editApplicant(body):
    pass

def deleteApplicant(body):
    pass

def get_database():
 
   # Provide the mongodb atlas url to connect python to mongodb using pymongo
   CONNECTION_STRING = "mongodb://admin:password@localhost/?authSource=admin"
 
   # Create a connection using MongoClient. You can import MongoClient or use pymongo.MongoClient
   client = MongoClient(CONNECTION_STRING)
 
   # Create the database for our example (we will use the same database throughout the tutorial
   return client['crm-db']
  
# This is added so that many files can reuse the function get_database()




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

# Get the database
db = get_database()

app = connexion.FlaskApp(__name__, specification_dir='')
app.add_api("openapi.yml", base_path="/processing", strict_validation=True, validate_responses=True)

if "TARGET_ENV" not in os.environ or os.environ["TARGET_ENV"] != "test":
    CORS(app.app)
    app.app.config['CORS_HEADERS'] = 'Content-Type'

if __name__ == "__main__":
    app.run(port=8100)
    # app.run(port=8100, debug=False)