// let dssv = [
//     {
//         hoten: "Nguyen Van A",
//         dtb: 10,
//         diaChi: {
//             soNha: 60,
//             duong: "Huynh Thuc Khang"
//         },
//         getDiaChi: function () {
//             return this.diaChi.soNha + " " + this.diaChi.duong;
//         }
//     },
//     {
//         hoten: "Nguyen Van B",
//         dtb: 8,
//         diaChi: {
//             soNha: 100,
//             duong: "Huynh Thuc Khang 33333"
//         },
//         getDiaChi: function () {
//             return this.diaChi.soNha + " " + this.diaChi.duong;
//         }
//     }
// ];
class SinhVien
{
    constructor(hoten, dtb, soNha,duong)
    {
        this.hoten = hoten,
        this.dtb = dtb,
        this.diaChi = new DiaChi(soNha, duong),
        this.getDiaChi = function () {
            return this.diaChi.soNha + " " + this.diaChi.duong
        } 
    }
}
class DiaChi 
{
    constructor(soNha, duong)
    {
        this.soNha = soNha,
        this.duong = duong
    }
}
let dssv = [];
dssv.push(new SinhVien("Nguyen Van A", 10, 60, "Huynh Thuc Khang"))
dssv.push(new SinhVien("Nguyen Van B", 10, 100, "Dien Bien Phu"))
dssv.forEach(items => document.getElementById("tbody").innerHTML += 
    `<tr>
        <td>${items.hoten}</td>
        <td>${items.dtb}</td>
        <td>${items.getDiaChi()}</td>
    </tr>`
);