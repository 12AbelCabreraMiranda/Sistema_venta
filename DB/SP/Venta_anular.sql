USE [dbsistema]
GO
/****** Object:  StoredProcedure [dbo].[venta_anular]    Script Date: 7/21/2019 11:43:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[venta_anular]
@idventa int
as
update venta set estado='Anulado'
where idventa=@idventa;
update articulo
set stock=stock+d.cantidad
from articulo a
inner join
(select idarticulo,cantidad from detalle_venta where idventa=@idventa) as d
on a.idarticulo=d.idarticulo;
