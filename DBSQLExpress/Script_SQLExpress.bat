:: @file:   Script_SQLExpress.bat
:: @author: Alejandro Molina Pulido
:: @email:  am.alex09@gmail.com
:: @date:   Octubre 2018
:: @brief:  This file create the TestSQLExpress database from sql file.

mkdir c:\DataBase\TestSQLExpress
osql -S .\SQLExpress2014 -E -i "Script_SQLExpress.sql"
pause