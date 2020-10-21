
export default function GetCompressedString() {

    return fetch("https://localhost:44357/api/DataModels/GetCompressedString/AAABBCCCDAAF").then((response) => {
        return response;
    })
}
