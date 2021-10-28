var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;

function searchPokemon() {  
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
    .then(response => response.json())
    .then(pokemon => {
        var parent = document.getElementById('parent');
        parent.innerHTML = '<p>' + pokemon.name +'</p>';
        parent.innerHTML += "<img src=" + pokemon.sprites.front_default + ">";
        var attacks = document.getElementById('attacks');
        var firstMove = pokemon.moves[0].move.name;
        var secondMove = pokemon.moves[1].move.name;
        var thirdMove = pokemon.moves[2].move.name;
        var fourthMove = pokemon.moves[3].move.name;
        attacks.innerHTML = '<p>' + pokemon.name + ", It's dangerous to go alone, take these! " + '</p>' + '<p>' + firstMove + '<p>' + secondMove + '</p>'+ '<p>' + thirdMove + '</p>'+ '<p>' + fourthMove +'</p>';
       

         

    }).catch(err => console.log(err))
}