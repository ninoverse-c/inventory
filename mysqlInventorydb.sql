create database if not exists inventory_db character set utf8mb4;
use inventory_db;
select * from activity_log;
create table users (
user_id int auto_increment primary key,
username varchar(50) not null unique,
password varchar(255) not null,
fullname varchar(150) not null,
user_role varchar(20) not null default 'staff',
is_active tinyint(1) not null default 1
);

create table products (
product_id int not null auto_increment,
product_name varchar(150) not null,
category varchar(100),
description text,
unit_price decimal(10,2) not null default 0.00,
quantity int not null default 0,
reorder_level int not null default 10,
created_at datetime not null default current_timestamp,
primary key (product_id)
);

create table stock_transactions (
transaction_id int not null auto_increment,
product_id int not null,
transaction_type ENUM('IN','OUT','ADJUSTMENT') not null,
quantity int not null,
reference_note varchar(255),
transaction_date datetime not null default current_timestamp,
created_by int not null,
primary key (transaction_id),
constraint fk_trans_product foreign key (product_id) references products(product_id),
constraint fk_trans_user foreign key(created_by) references users(user_id)
);
select * from stock_transactions;

create table activity_log (
log_id int not null auto_increment,
username varchar(50) not null,
action_name varchar(100) not null,
details text,
action_at datetime not null default current_timestamp,
primary key (log_id)
);

USE inventory_db;
DESCRIBE users;
describe products;
describe stock_transactions;
describe activity_log;
