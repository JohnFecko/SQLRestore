SQLRestore
==========

As a developer with maintaing line of business apps with highly customizable data options, many times the only way to isolate a problem is to debug against a live database.  This can mean restoring backups of databases multiple times per day.  This tool provides a quick and easy way to restore a database.


Authentication
--------------

Currently the only authentication method that is available is for the local windows user to have proper database permissions to restore the database.


Database Instance
-----------------

Currently the database being restored to must be the default instance on the machine where SQLRestore is being used.
