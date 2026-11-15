USE inventory_db;

-- 1) Add the cellphone detail columns to the products table
ALTER TABLE products
  ADD COLUMN cpu varchar(100) AFTER category,
  ADD COLUMN ram varchar(50) AFTER cpu,
  ADD COLUMN storage varchar(50) AFTER ram;

-- 2) Sample cellphone data (optional)
INSERT INTO products (product_name, category, cpu, ram, storage, description, unit_price, quantity, reorder_level) VALUES
('Samsung Galaxy A55', 'Smartphone', 'Exynos 1480', '8GB', '256GB', '6.6 inch AMOLED, 5000mAh', 21990.00, 15, 5),
('iPhone 13', 'Smartphone', 'Apple A15 Bionic', '4GB', '128GB', '6.1 inch OLED', 36990.00, 8, 3),
('Xiaomi Redmi Note 13', 'Smartphone', 'Snapdragon 685', '8GB', '256GB', '6.67 inch AMOLED, 108MP camera', 11990.00, 20, 8),
('Realme C55', 'Smartphone', 'Helio G88', '6GB', '128GB', '6.72 inch, 64MP camera', 7990.00, 4, 5);

-- 3) IMPORTANT FIX: your C# code uses "full_name" but your users table has "fullname"
ALTER TABLE users CHANGE fullname full_name varchar(150) not null;
