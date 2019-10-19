function lisays() {
    let a = [50, 70, 30, 2, 40, 24, 19, 60];
    console.log("Aloitus array: " + a)
    for (let i = 1; i < a.length; i++) {
        //nykyinen paikka
        let k = a[i];
        let j = i -1;
        while(j >=0 && a[j] > k) {
            a[j+1]=a[j];
            j = j - 1;
        }
        a[j+1] = k;
        console.log("i = " + i + ": "+ a);
    }
    console.log(a);
}