import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { InfoCarousel } from "./InfoCarousel";
import PrettyPrintJson from "./prettyPrintJSON";
export const SearchRecipies: React.FC = () => {

    const [userInput, setUserInput] = React.useState("");

    const meals2 = useRecipies({
        query: userInput
    })

    return (
        <>
            <input value={userInput} onChange={(event) => {
                setUserInput(event.target.value);
            }} />

            {meals2.isLoading && <div><h1>Is loading!!!</h1></div>}

            <PrettyPrintJson data={meals2.data} />
        </>
    );
};
