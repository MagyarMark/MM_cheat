function meret(tartaly){
    teto=document.getElementById('tetofelulet').value;
    csapadek=document.getElementById('csapadek').value;
    
    eso = teto * csapadek;
    meret = Math.ceil((eso / 3000), 1);
    
    document.getElementById('gyujtott').value = eso;
}