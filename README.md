# CRUDVehicle
Simple CRUD for cars registry.

References:
https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures


SQL script to populate db:
INSERT INTO [Cars]
([Name], [MakeId], [DoorQty], [TransmissionType], [Year], [FuelType] ) 
    VALUES
        ('Ka', 1, 5, 0, 2012, 1),
        ('Corsa', 6, 5, 0, 2012, 1),
        ('Pajero TR4', 5, 5, 2, 2012, 0),
        ('Fiesta', 1, 5, 0, 2000, 1),
        ('Civic', 10, 4, 2, 2021, 0),
        ('C5', 4, 5, 2, 2020, 0)
