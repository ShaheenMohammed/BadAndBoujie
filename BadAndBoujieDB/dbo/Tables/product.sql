create table product 
	(P_ID	varchar(10) not null,
	S_ID		varchar(10) not null,
	P_cat_ID	varchar(10) not null,
	gender varchar(10) not null,
	/*stock number goes here and remove stock table*/
	inStock int not null,
	P_price	varchar(10) not null,
	P_sale	varchar(10) not null, 
	primary key (P_ID)
	);
GO
alter table product
add foreign key (S_ID) references supplier;
GO
alter table product
add foreign key (P_cat_ID) references P_cat;