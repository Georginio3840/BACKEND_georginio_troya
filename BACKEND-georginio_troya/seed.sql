INSERT INTO "Customers" ("CustomerId", "Fname", "Lname", "Address", "Phone", "Email") VALUES
(1, 'Ana', 'Pérez', 'Calle 123', '099111222', 'ana.perez@email.com'),
(2, 'Luis', 'Martínez', 'Av. Central 456', '098888999', 'luis.martinez@email.com');


INSERT INTO "OrderHeaders" ("OrderId", "OrderDate", "OrderTime", "CustomerId") VALUES
(1, '2025-05-28', '10:30:00', 1),
(2, '2025-05-28', '11:00:00', 2),
(3, '2025-05-29', '08:45:00', 1);


INSERT INTO "Deliveries" ("DeliveryId", "OrderId", "Type", "Status", "Departure", "Arrival") VALUES
(1, 1, 'Express', 'En tránsito', '2025-05-28 12:00:00', '2025-05-28 18:00:00'),
(2, 1, 'Normal', 'Entregado', '2025-05-28 09:00:00', '2025-05-28 13:30:00'),
(3, 2, 'Urgente', 'En tránsito', '2025-05-28 11:30:00', '2025-05-28 15:00:00');
