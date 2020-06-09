create table shopping_basket
	(shopping_basket_ID	int not null,
	C_ID		varchar(10) not null,
	basket_datetime	datetime not null,
	primary key (shopping_basket_ID)
	);
GO
alter table shopping_basket
add foreign key (C_ID) references customer;