import React from "react";

function Header() {
  const date = new Date();
  const hours = date.getHours();
  let gruss;

  if (hours < 12) gruss = "Guten Morgen";
  else if (hours >= 12 && hours < 16) gruss = "Guten Tag";
  else if (hours >= 16 && hours <= 19) gruss = "Guten Abend";
  else gruss = "Gute Nacht";

  return (
    <div className="navbarDiv">
      <header className="navbarHeader">
        <h1> My Header </h1>
      </header>
      <span className="headerDateTime">
        es ist &nbsp;
        {date.getDate()}-{date.getMonth()}-{date.getFullYear()}
        {date.getHours()}:{date.getMinutes()}:{date.getSeconds()}:
        {date.getMilliseconds()} {gruss}!
      </span>
    </div>
  );
}

export default Header;
