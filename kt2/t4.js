let yht = 0;
function lomituslajittelu () {
    let a = [60, 170, 30, 2, 11, 19, 24, 50, 60, 3, 100];
    console.log(lomitus(a));
    console.log(yht)
}

function lomitus(a) {
    if (a.length <= 1) return a;
    let keskikohta = Math.floor(a.length/2);
    let o = a.slice(0, keskikohta);
    let v = a.slice(keskikohta);
    return yhdista(
        lomitus(v), lomitus(o)
    );
}

function yhdista(v, o) {
    let vlkm = 0;
    let olkm = 0;
    let tulos = [];
    let i0 = 0;
    let i1 = 0;

    while (i0 < v.length && i1 < o.length) {
        //lisää vaihteen kohdalle +1 jokaisen iteraation kohdalla
        
        if (v[i0] < o[i1]) {
            tulos.push(v[i0]);
            i0++;
            vlkm++;
        } else {
            tulos.push(o[i1]);
            i1++;
            olkm++;
        }
    }
    //vaiheen jälkeen lisätään vaiheeseen +1
    console.log("vasen =" + vlkm);
    console.log("oikea =" + olkm);
    console.log("yht =" + (vlkm + olkm))
    yht += (vlkm + olkm);
    yht++;

    return tulos.concat(v.slice(i0)).concat(o.slice(i1));
}