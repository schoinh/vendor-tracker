# Vendor and Order Tracker

#### _Web application for tracking vendors that purchase goods from Pierre's Bakery and the orders belonging to the vendors - August 2, 2019_

#### _By **Na Hyung Choi**_

## Description

Pierre can now view and manage his vendors online. This Web site allows for adding new vendors, adding new orders for a given vendor, viewing vendor details and their orders, and editing vendor details. It does not allow for deleting of any vendors or orders. MSTest was used to test the business logic for the Vendors class.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Displays list of vendors, if any** | Click "My Vendors" | List of vendors, if any |
| **Allows user to add new vendors** | Click "New Vendor" | Blank form for submitting new vendor details |
| **Allows user to edit vendor details** | Click "Edit Vendor" | Blank form for submitting changes in vendor details |
| **Allows user to add new orders for a vendor** | Click "New Order" | Blank form for submitting information about new order |
| **Displays list or orders for each vendor, if any** | Click a vendor from My Vendors | List of orders, if any |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone https://github.com/schoinh/vendor-tracker.git
    ```
2. Navigate to the production folder (VendorOrderTracker.Solution/VendorOrderTracker)

3. Restore dependencies and run the application
    ```
    $ dotnet restore
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
* ASP.NET Core MVC
* MSTest

## Support and contact details

_Please contact Na Hyung with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Na Hyung Choi_**
