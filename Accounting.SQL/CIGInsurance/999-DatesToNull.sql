use [CIGinsurance]
go 

DECLARE @cmd nvarchar(max)
declare @table nvarchar(30), @column nvarchar(30)

declare cDate cursor for 
	SELECT TABLE_NAME, COLUMN_NAME 
	FROM INFORMATION_SCHEMA.COLUMNS 
	where TABLE_SCHEMA != 'tmp' and  data_type = 'smalldatetime'

open cDate
fetch next from cDate into @table, @column
while @@FETCH_STATUS = 0
begin
	set @cmd = 'update '+@table+' set '+@column+' = null where '+@column+' = 01/01/1900'

	EXEC SP_EXECUTESQL @CMD
	fetch next from cDate into @table, @column
end 
close cDate
deallocate cDate