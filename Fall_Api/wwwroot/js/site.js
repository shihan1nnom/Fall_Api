const uri = "api/Datos";
let todos = [];

function getDatos() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('No se pudo obtener datos', error));
}

function _displayCount(itemCount) {
    const name = (itemCount == 1) ? 'to-do' : 'to-dos';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tbody = document.getElementById('todos');
    tbody.innerHTML = '';

    _displayCount(data.lenght);

    const button = document.createElement('button');
    button.setAttribute('class', 'btn');

    data.forEach(item => {
        let isCompleteChecbox = document.createElement('input');
        isCompleteChecbox.type = 'checkbox';
        isCompleteChecbox.disabled = true;
        isCompleteChecbox.checked = item.isComplete;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', '');

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tbody.insertRow();

        let td1 = tr.insertRow(0);
        td1.appendChild(isCompleteCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.name);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    todos = data;
}