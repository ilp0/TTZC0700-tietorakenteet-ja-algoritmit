function sekoita(){
    let v = [79, 73, 75, 69, 65];
    let avain = [1,3,0,4,2];
    let paikka = 0;
    let tulos = [];
    for(let i = 0; i < v.length; i++){
        paikka = avain[i];
        tulos[paikka] = v[i];
    }
    console.log(tulos);
}