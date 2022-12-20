SELECT p.name, c.name
FROM Products p
LEFT JOIN ProductCategories pc
	ON p.id = pc.prod_id
LEFT JOIN Categories c
	ON pc.cat_id = c.Id;