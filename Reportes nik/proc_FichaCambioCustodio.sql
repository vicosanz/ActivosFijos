create PROCEDURE proc_FichaCambioCustodio 
	@codigo	int = null
AS
BEGIN
	Select * from vw_FichaCambioCustodio
		where codigo=@codigo
END
