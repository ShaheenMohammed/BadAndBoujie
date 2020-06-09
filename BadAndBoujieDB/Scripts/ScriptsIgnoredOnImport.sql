
/*populate tables next */
INSERT INTO P_cat (P_cat_ID, P_cat_name ) VALUES ('PCat001', 'Pants');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat002', 'Tops');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat003', 'Skirts');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat004', 'Socks');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat005', 'Shoes');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat006', 'Hats');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH001','Storage Depot', '12 Dockside Rd.', '3217382293');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH002','Freight Experts', '222 Airport Way', '4423648523');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH003','Continental Imports', '33 Industrial Ave.', '5556429956');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S001', 'WH001', 'Acme Textiles', '45 Piedmont St.', '5555551234');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S002', 'WH002', 'Regent Garments', '123 High St.', '5555556666');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S003', 'WH003', 'Pacific Pro-Wear', '33-A Main St.', '5555558925');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S004', 'WH003', 'Seagull Fashions', '56 Cervantes Rd.', '5555557732');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P001', 'S001', 'PCat001',	'Female',100, '29.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P002', 'S001', 'PCat002',	'Female', 120,'49.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P003', 'S001', 'PCat003',	'Male', 23,'24.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P004', 'S002', 'PCat004',	'Male', 75,'9.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P005', 'S002', 'PCat005',	'Male', 2,'149.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P006', 'S002', 'PCat006',		'Female', 87, '39.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P007', 'S003', 'PCat001',		'Female', 233,'59.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P008', 'S003', 'PCat002' ,	'Female', 834,'23.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P009', 'S003', 'PCat003',	'Male', 9,'30.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P010', 'S004', 'PCat004'	,	'Male',87, '8.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P011', 'S004', 'PCat005' ,	'Male', 40,'49.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P012', 'S004', 'PCat006',	'Female', 34,'89.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P013', 'S004', 'PCat001'	,	'Male', 82, '79.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P014', 'S001', 'PCat002' ,	'Female', 723,'19.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P015', 'S003', 'PCat003' 	,	'Male', 45,'39.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P016', 'S003', 'PCat004'	,	'Male', 33,'3.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P017', 'S003', 'PCat005',	'Male', 67,'116.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P018', 'S003', 'PCat006', 	'Female', 102, '22.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P019', 'S003', 'PCat001'	,'Male', 282,'67.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P020', 'S003', 'PCat002', 	'Female',3, '15.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P021', 'S003', 'PCat003',	'Male', 55,'24.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P022', 'S003', 'PCat004'	,	'Female',12, '7.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P023', 'S003', 'PCat005' ,	'Male', 69,'99.99','0');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P001', 'Cavalier');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P002', 'Confident');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P003', 'Durango');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P004', 'Shoreline');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P005', 'Charisma');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P006', 'Breeze');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P007', 'Canopy');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P008', 'Nightfall');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P009', 'Watershed');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P010', 'Sky');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P012', 'Vacation');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P013', 'Trek');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P014', 'Sandpiper');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P015', 'Glen');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P016', 'Knoll');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P017', 'Voyager');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P018', 'Freemont');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P019', 'Boardwalk');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P020', 'Seawall');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P021', 'Starfield');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P022', 'Ombre');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P023', 'Regiment');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per001', 'George', 'Livermore', '7788813744','33 Maple St.', 'glivermore','uhiafasif','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per002', 'Sandra', 'Kelvin', '7784529945','2365 134th St.', 'skelvin','eurhslrhsdljrh','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per003', 'Sunita', 'Moore', '6046672945','56 Pinebud Ave.', 'smoore','kejhadfkd','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per004', 'Jenny', 'Wong', '6045562354','3004 Royal St.', 'jwong','krishhd','Staff');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per005', 'Harold', 'Fulton', '7786567812','44 Clayton Cres.', 'hfulton','reahfdsfdg','Staff');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C001', 'Per001');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C002', 'Per002');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C003', 'Per003');
GO

INSERT INTO staff (stf_ID, Per_ID) VALUES ('S001', 'Per004');
GO

INSERT INTO staff (stf_ID, Per_ID) VALUES ('S002', 'Per005');
GO

/*populate tables*/

INSERT INTO P_cat (P_cat_ID, P_cat_name ) VALUES ('PCat001', 'Pants');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat002', 'Tops');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat003', 'Skirts');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat004', 'Socks');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat005', 'Shoes');
GO

INSERT INTO P_cat (P_cat_ID, P_cat_name) VALUES ('PCat006', 'Hats');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH001','Storage Depot', '12 Dockside Rd.', '3217382293');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH002','Freight Experts', '222 Airport Way', '4423648523');
GO

INSERT INTO warehouse (W_ID, W_name, W_addr, W_phone) VALUES ('WH003','Continental Imports', '33 Industrial Ave.', '5556429956');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S001', 'WH001', 'Acme Textiles', '45 Piedmont St.', '5555551234');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S002', 'WH002', 'Regent Garments', '123 High St.', '5555556666');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S003', 'WH003', 'Pacific Pro-Wear', '33-A Main St.', '5555558925');
GO

INSERT INTO supplier (S_ID, W_ID, S_name, S_addr, S_phone) VALUES ('S004', 'WH003', 'Seagull Fashions', '56 Cervantes Rd.', '5555557732');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P001', 'S001', 'PCat001',	'Female',100, '29.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P002', 'S001', 'PCat002',	'Female', 120,'49.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P003', 'S001', 'PCat003',	'Male', 23,'24.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P004', 'S002', 'PCat004',	'Male', 75,'9.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P005', 'S002', 'PCat005',	'Male', 2,'149.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P006', 'S002', 'PCat006',		'Female', 87, '39.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P007', 'S003', 'PCat001',		'Female', 233,'59.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P008', 'S003', 'PCat002' ,	'Female', 834,'23.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P009', 'S003', 'PCat003',	'Male', 9,'30.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P010', 'S004', 'PCat004'	,	'Male',87, '8.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P011', 'S004', 'PCat005' ,	'Male', 40,'49.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P012', 'S004', 'PCat006',	'Female', 34,'89.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P013', 'S004', 'PCat001'	,	'Male', 82, '79.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P014', 'S001', 'PCat002' ,	'Female', 723,'19.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P015', 'S003', 'PCat003' 	,	'Male', 45,'39.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P016', 'S003', 'PCat004'	,	'Male', 33,'3.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P017', 'S003', 'PCat005',	'Male', 67,'116.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P018', 'S003', 'PCat006', 	'Female', 102, '22.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P019', 'S003', 'PCat001'	,'Male', 282,'67.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P020', 'S003', 'PCat002', 	'Female',3, '15.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P021', 'S003', 'PCat003',	'Male', 55,'24.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P022', 'S003', 'PCat004'	,	'Female',12, '7.99','0');
GO

INSERT INTO product (P_ID, S_ID, P_cat_ID, gender, inStock, P_price, P_sale) VALUES ('P023', 'S003', 'PCat005' ,	'Male', 69,'99.99','0');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P001', 'Cavalier');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P002', 'Confident');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P003', 'Durango');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P004', 'Shoreline');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P005', 'Charisma');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P006', 'Breeze');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P007', 'Canopy');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P008', 'Nightfall');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P009', 'Watershed');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P010', 'Sky');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P012', 'Vacation');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P013', 'Trek');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P014', 'Sandpiper');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P015', 'Glen');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P016', 'Knoll');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P017', 'Voyager');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P018', 'Freemont');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P019', 'Boardwalk');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P020', 'Seawall');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P021', 'Starfield');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P022', 'Ombre');
GO

INSERT INTO product_name (P_ID, P_name) VALUES ('P023', 'Regiment');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per001', 'George', 'Livermore', '7788813744','33 Maple St.', 'glivermore','uhiafasif','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per002', 'Sandra', 'Kelvin', '7784529945','2365 134th St.', 'skelvin','eurhslrhsdljrh','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per003', 'Sunita', 'Moore', '6046672945','56 Pinebud Ave.', 'smoore','kejhadfkd','Customer');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per004', 'Jenny', 'Wong', '6045562354','3004 Royal St.', 'jwong','krishhd','Staff');
GO

INSERT INTO person (Per_ID, Per_firstname, Per_lastname, Per_phone, Per_addr,	Per_usrn, Per_PW, Per_type) VALUES ('Per005', 'Harold', 'Fulton', '7786567812','44 Clayton Cres.', 'hfulton','reahfdsfdg','Staff');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C001', 'Per001');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C002', 'Per002');
GO

INSERT INTO customer (C_ID, Per_ID) VALUES ('C003', 'Per003');
GO

INSERT INTO staff (stf_ID, Per_ID) VALUES ('S001', 'Per004');
GO

INSERT INTO staff (stf_ID, Per_ID) VALUES ('S002', 'Per005');
GO
