# hada
# Winmdows 10 Ubuntui aus dem Store Installieren
# Dann kommt fix ein fehler -> hier fehlen die Featuren Windows Linux Subsystem
# einfach Windows Features aktivieren und deaktivieren wählen
# dor Windows-Subsystem für Linux anhackln.. dann gehts


# das hier muss so installiert werden 
wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb

sudo add-apt-repository universe
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update

sudo apt-get install dotnet-sdk-2.1
sudo apt-get install aspnetcore-runtime-2.1
sudo apt-get install dotnet-runtime-2.1

sudo apt-get install dotnet-sdk-3.1
sudo apt-get install aspnetcore-runtime-3.1
sudo apt-get install dotnet-runtime-3.1




dann mkdir ordner machen
und dort dann folgendes ausführen


# ---------------------------------------------------------------------
# wobei wenn man nur eine file hat kann man sich die solution auch schenken


dotnet new sln -o NAMEDERAPP
# hier legt man die solution an




dotnet new console -lang F# -o src/App
# hier legt man eine ganz normale App an



dotnet sln add src/App/App.fsproj
# hier wird sie auf die solution gelinkt kann man sich aber schenken bei einer file


dotnet add Package "NUGETPACKAGENAME"
#hier wird dann alles in die App.fsproj reingespielt und fertig
#dotnet run im richtigen ordner wo due fsproj und die fs liegt und die kiste rennt

dotnet run


das isses





