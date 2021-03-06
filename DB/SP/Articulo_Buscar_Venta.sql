create proc articulo_buscar_venta
@valor varchar(50)
as
select a.idarticulo as ID,a.idcategoria,c.nombre as Categoria,
a.codigo as Codigo,a.nombre as Nombre,a.precio_venta as Precio_Venta,
a.stock as Stock,a.descripcion as Descripcion,a.imagen as Imagen,
a.estado as Estado
from articulo a inner join categoria c on a.idcategoria=c.idcategoria
where (a.nombre like '%' +@valor + '%' Or a.descripcion like '%' +@valor + '%')
and a.stock>0
order by a.nombre asc
