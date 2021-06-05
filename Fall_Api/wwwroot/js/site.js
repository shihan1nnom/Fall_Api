const uri_datos = "api/Datos";
const uri_cancelaciones = "api/Cancelaciones";

function getDatos() {
    fetch(uri_datos)
        .then(response => response.json())
        .then(data_datos => _displayItems(data_datos))
        .catch(error => console.error('No se pudo obtener datos', error));
}

function getCancelaciones() {
    fetch(uri_cancelaciones)
        .then(response => response.json())
        .then(data_cancelacion => _displayItems(data_cancelacion))
        .catch(error => console.error('No se pudo obtener datos', error));
}

function _displayItems(data) {
    const tbody = document.getElementById('resultados');
    tbody.innerHTML = '';

    data.forEach(r => {
        let tr1 = document.createElement('tr');
        tbody.appendChild(tr1);

        let td1 = document.createElement('td');
        td1.textContent = r.oc;
        tr1.appendChild(td1);

        let td2 = document.createElement('td');
        td2.textContent = r.f12;
        tr1.appendChild(td2);

        let td3 = document.createElement('td');
        td3.textContent = r.sku;
        tr1.appendChild(td3);

        let td4 = document.createElement('td');
        td4.textContent = r.cc;
        tr1.appendChild(td4);
    });
}