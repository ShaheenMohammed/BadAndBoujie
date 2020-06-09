create table basket_contents_line
	(basket_contents_line_ID	int not null,
	shopping_basket_ID	int not null,
	P_ID		varchar(10) not null,
	quantity int not null,
	primary key (basket_contents_line_ID)
	);
GO
/*alter table shopping_basket
add foreign key (basket_contents_line_ID) references basket_contents_line; */

alter table basket_contents_line
add foreign key (P_ID) references product;
GO
alter table basket_contents_line
add foreign key (shopping_basket_ID) references shopping_basket;