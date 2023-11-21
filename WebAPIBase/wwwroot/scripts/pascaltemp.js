window.onload = function () {
    //mi történik ha betöltődött az oldal
    drawPascal(10);

    //control.log(szam);
}

var drawPascal = function (sorSzam) {
    //itt történi a Pascal háromszög DOM elemeinek létrehozása és elhelyezése

    //var szam = 5;
    //var szoveg = "xyz";

    //let szam = 5;

    //új div létrehozása az új sornak
    var ujSorDiv = document.createElement('div');
    //új div osztálylistájához add hozzá a "sor"-t
    ujSor.classList.add('sor')
    //új div-et add hozzá a "pascal" gyermekeihez
    pascalDiv.appendChild(ujSorDiv);

    for (var oszlop = 0; oszlop <= sor; oszlop++) {
        //új div létrehozása az új elemnek
        var ujElem = document.createElement('div');
        //új elem div osztálylistájához add hozzá az "elem"-et
        ujElem.classList.add('elem');
        //ujElemDiv.innerText = sor +';' + oszlop
        ujElemDiv.innerText = faktorialis(sor) / (faktorialis(oszlop) * faktorialis(sor - oszlop));

        ujSorDiv.appendChild(ujElemDiv);

        //teszteléshet .innerHTML = `${sor}:${oszlop}`

        //legyen az innerHTML a megfelelő szám
        //új elem div-et vedd fel a sor elemei közé
       

    }
}

//új DOM elem létrehozása
//var ujElem = document.createElement('div');
//ujElem.classList.add('ujosztály');
//ujElem.id = 'ujID'
//ujElem.innerText = '0';
//ujElem.innerHTML = '<div>Hello!</div>';

//var szuloElem = document.getElementById('szulo');
//szuloElem.appendChild(ujElem);

