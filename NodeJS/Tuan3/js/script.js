//fetch data 1
// async function getData() {
//     let response = await fetch("../sv.json")
//     let sv = await response.json()
//     document.getElementById("p").innerHTML = sv.hoTen
// }
// getData()
//fetch data 2
fetch("https://jsonplaceholder.typicode.com/comments")
    .then(response => response.json())
    .then(comments => comments.forEach(items => {
        document.getElementById("tbody").innerHTML +=
    `<tr>
        <td>${items.postId}</td>
        <td>${items.id}</td>
        <td>${items.name}</td>
        <td>${items.email}</td>
        <td>${items.body}</td>
    </tr>`
    })
)
