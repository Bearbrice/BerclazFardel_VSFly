![Program](https://img.shields.io/badge/program-Visual%20Studio-blueviolet)
![State](https://img.shields.io/badge/state-completed-success)
![License](https://img.shields.io/badge/license-MIT-green)

# BerclazFardel_VSFly 

This project was carried out as part of the "634-1 - Components and patterns" module for both pattern and component courses.

## Installation

Just unzip the compressed file (.zip) and open the two solutions files (.sln) in two distinct Visual Studio.

## Configuration

To be able to run this project localy you need to change the attribute ConnectionString in the VSFlightContext.

### 1. Copy connection string of the database
*BerclazFardel_VSFly -> VSFly_BerclazFardel_WebAPI -> EFCore -> VSFlyDB.mdf*

Go on properties and copy the full path.

### 2. Set attribute ConnectionString
*BerclazFardel_VSFly -> VSFly_BerclazFardel_WebAPI -> WebAPI -> Model -> VSFlightContext.cs*

Set the correct value for the attribute ConnectionString in the class *VsFlightContext.cs*. Paste the full path of the database in the correct place.

## Usage

You can directly launch it from Visual Studio. First run the API part (API solution) via IIS Express and then the client WebApplication (other solution) in IIS Express as well.

## License
[MIT](https://choosealicense.com/licenses/mit/) :octocat:
