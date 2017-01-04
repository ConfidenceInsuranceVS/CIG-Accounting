/* WARNING: THE SAMPLE BELOW; DROPS ALL THE DEFAULT CONSTRAINTS IN A DATABASE */ 
/* MAY 03, 2013 - BY WISEROOT  */
use [CIGinsurance]
go

declare @table_name nvarchar(128)
declare @column_name nvarchar(128)
declare @df_name nvarchar(128)
declare @cmd nvarchar(128) 

declare table_names cursor for 
 SELECT t.name TableName, c.name ColumnName
 FROM sys.columns c INNER JOIN
     sys.tables t ON c.object_id = t.object_id INNER JOIN
     sys.schemas s ON t.schema_id = s.schema_id
     ORDER BY T.name, c.name

open table_names
fetch next from table_names into @table_name , @column_name
while @@fetch_status = 0
BEGIN

if exists (SELECT top(1) d.name from sys.tables t join sys.default_constraints d on d.parent_object_id = t.object_id join sys.columns c on c.object_id = t.object_id and c.column_id = d.parent_column_id where t.name = @table_name and c.name = @column_name)
BEGIN
    SET @df_name = (SELECT top(1) d.name from sys.tables t join sys.default_constraints d on d.parent_object_id = t.object_id join sys.columns c on c.object_id = t.object_id and c.column_id = d.parent_column_id where t.name = @table_name and c.name = @column_name)
    select @cmd = 'ALTER TABLE [' + @table_name +  '] DROP CONSTRAINT [' +  @df_name + ']'
    print @cmd
    EXEC sp_executeSQL @cmd;
END

  fetch next from table_names into @table_name , @column_name
END

close table_names 
deallocate table_names