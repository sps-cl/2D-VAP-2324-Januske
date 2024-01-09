let tlacitko = document.getElementById("tlacitko");
let number1 = document.getElementById("pocet-radku");
let number2 = document.getElementById("pocet-sloupcu");

function vytvoritTabulku() {


    let Table = document.querySelector("table");

    if (Table) {
        Table.remove();
    }

    let table = document.createElement("table") 

    for (let i = 0; i < number1.value; i++) {
        let radky = table.insertRow();

        for (let j = 0; j < number2.value; j++) {
           let sloupce = radky.insertCell();
            sloupce.innerText= (i * number2.value) + j + 1;
            
        }
        
    }
    document.body.appendChild(table)
}
  