USE [dbsistema]
GO
/****** Object:  StoredProcedure [dbo].[ingreso_anular]    Script Date: 7/21/2019 11:23:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ingreso_anular]
@idingreso int
as
update ingreso set estado='Anulado'
where idingreso=@idingreso;
update articulo 
set stock=stock-d.cantidad
from articulo a
inner join
(select idarticulo,cantidad from detalle_ingreso where idingreso=@idingreso) as d
on a.idarticulo=d.idarticulo;