test_manual=Vyzkoušet konfigurační soubor po ručních úpravách?,1,1-Ano,0-Ne
virt_name=Název předlohy pro virtuální servery,3,Výchozí ($DOM.conf)
graceful_cmd=Příkaz pro znovunačtení konfigurace,3,Stejný jako příkaz pro uplatnění
httpd_dir=Kořenový adresář Apache serveru,0
apply_cmd=Příkaz upravující konfiguraci,10,-Použít apachectl nebo HUP signal,restart-Spustit stop a start příkazy
test_config=Otestovat konfigurační soubor před zápisem změn?,1,1-Ano,0-Ne
defines_name=Název proměnné prostředí u výše uvedené souboru,0
line1=Možnosti konfigurace,11
apache_docbase=Adresář s dokumentací Apache,3,Apache website
auto_mods=Detekovat Apache moduly vždy automaticky?,1,1-Ano,0-Ne
start_cmd=Příkaz pro spuštění Apache,3,Automaticky
httpd_version=Verze Apache,3,Automatizovaná práce
pid_file=Cesta k souboru PID Apache,3,Určuje se automaticky
show_names=Ukázat názvy Apache direktiv?,1,1-ano,0-ne
access_conf=Cesta k access.conf,3,Automaticky
link_dir=Adresář pro vytvoření linků určených pro nové virtuální servery,3,Nic
httpd_path=Cesta ke spuštění httpd,0
srm_conf=Cesta k srm.conf,3,Automaticky
max_servers=Maximální počet sobrazených serverů,0,5
httpd_conf=Cesta k httpd.conf,3,Automaticky
line2=Konfigurace systému,11
apachectl_path=Cesta k apachectl příkazu,3,Nic
show_order=Seřadit virtuální servery podle,1,0-pořadí v konfiguračních souborech,1-názvu serveru,2-IP adresy
test_always=Vyzkoušet konfigurační soubor před dalšími změnami?,1,1-Ano,0-Ne
test_apachectl=Vyzkoušet konfiguraci pomocí příkazu,1,1-<tt>apachectl configtest</tt>,0-<tt>httpd</tt> s volbou <tt>-D</tt>
line3=Proměnné Apache,11
defines_file=Soubor pro definici proměnných prostředí Apache,3,Nic
show_list=Zobrazit virtuální servery jako,1,0-ikony,1-seznam
stop_cmd=Příkaz pro ukončení Apache,3,Automaticky
mime_types=Cesta k mime.types,3,Automaticky
defines_mods=Adresáře obsahující moduly pro proměnné HAVE_,9,40,3,\t
virt_file=Virtuální servery se přidají do souboru,3,httpd.conf