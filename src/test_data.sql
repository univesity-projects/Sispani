-- INSERÇÕES DE TESTE

select * from inserir_usuario('admin', 'admin', 'Admin');
select * from inserir_usuario('', '', 'Tester');
select * from inserir_usuario('carlos', '123456', 'Carlos Machado');

select * from inserir_cliente('620.984.580-02', 'Joaquim Theo Arthur Galvão', '16.666.648-8', 'M', '2000-12-10', '(47) 98681-6936', null, 'Avenida 4ª Avenida', '104', '999', 'Centro', 'Balneário Camboriú', 'SC');			
select * from inserir_cliente('780.675.491-17', 'Sebastiana Mariana Vitória Araújo', '39.126.285-3', 'F', '2000-06-02', '(47) 99473-3220', '(47) 3578-1723', 'Rua Osvaldo Cecílio', '606', '999', 'Centro', 'Balneário Camboriú', 'SC');				 

select * from inserir_produto('0', 'Caixa Bis', '10', 'UN', '4.00', '6.00'); 
select * from inserir_produto('1', 'Caixa Pizza', '13', 'UN', '4.20', '13.35');
select * from inserir_produto('2', 'Caixa Lasanha', '15', 'UN', '5.32', '4.25');
select * from inserir_produto('3', 'Caixa Café', '8', 'UN', '3.60', '5.25');
select * from inserir_produto('4', 'Caixa Leite', '21', 'UN', '9.99', '31.25');
select * from inserir_produto('5', 'Alcool', '6', 'UN', '2.80', '30.25');
select * from inserir_produto('6', 'Garrafa Vodka', '4', 'UN', '19.00', '68.25');
select * from inserir_produto('7', 'Pão Francês', '50', 'KG', '6.00', '10.00');
select * from inserir_produto('8', 'Cuca de Farofa', '5', 'KG', '12.00', '22.90');
select * from inserir_produto('9', 'Café Premium Preparado', '30', 'LT', '3.00', '6.90');

select * from inserir_venda('622.207.819-25', '2020-03-25 19:10:25', 30.10, 0);
select * from inserir_venda('622.207.819-25', '2020-03-26 21:08:31', 0, 25);
select * from inserir_venda('251.454.429-71', '2020-03-26 21:08:31',  31, 10.15);
select * from inserir_venda(null, '2020-03-26 21:08:31', 31.50, 10.95);
select * from inserir_venda(null, '2020-03-26 21:08:31', 10.22, 0);
select * from inserir_venda(null, '2020-03-26 21:08:31', 5.33, 0);

select * from inserir_item_venda('1', '0', 1);
select * from inserir_item_venda('1', '1', 1);
select * from inserir_item_venda('1', '2', 2);
select * from inserir_item_venda('2', '4', 1);
select * from inserir_item_venda('2', '5', 4);
select * from inserir_item_venda('2', '6', 8);
select * from inserir_item_venda_multi(1, '{0, 1, 2, 3}', '{1, 3, 1, 2}');
