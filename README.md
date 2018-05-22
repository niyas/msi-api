# msi-api
An api which serves the endpoint for msi users

## Database Setup
This application uses Entity framework code first approach, so there is no need to create database manually. Simply run the application and the database and corresponsing tables will be created on the fly

*Note: Make sure to change the connection string in `web.config` file*

## Endpoints
*Url:* `/api/msi` 

*Method:* `POST`

*Sample Payload:*
```
{
  "firstName":"Mohammed",
  "lastName":"Niyas",
  "mi":"Mr",
  "suffix":"BE",
  "address":"No:37 third newStreet Ayapakkam",
  "city":"Chennai",
  "state":"TN",
  "zip":"600077"
}
```
