import { Nutrients } from "@api/client";
import useRecipies from "hooks/useRecipes";
import React, { useState } from "react";
import { InfoCarousel } from "./InfoCarousel";
import PrettyPrintJson from "./prettyPrintJSON";

interface IMealCard {
    title: string;
    nutrients: Nutrients;
    labels: string[];
    ingredientLines: string[];
    calories: number;
    cusine: string[];
    image: string;
    shareAs: number;
}

export const MealCard = (props: IMealCard) => {

    return (
        <>
            <th>
                <div className="card w-96 glass">
                    <figure><div className="avatar">
                        <div className="w-50 m-8  rounded-full shadow-2xl">
                            <img src={props.image ? props.image : "https://www.pngfind.com/pngs/m/194-1946786_png-file-taiwan-food-icon-transparent-png.png"} alt="NO Image" />
                        </div>
                    </div>
                    </figure>
                    <div className="card-body">
                        <h2 className="card-title">{props.title}</h2>
                        <h3 className="card-title">{(props.calories / props.shareAs).toFixed(0)}: Calories</h3>
                        <div className="card-actions justify-end">
                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                <div className="collapse-title text-xl font-medium">
                                    Ingredients:
                                </div>
                                <div className="collapse-content">
                                    {props.ingredientLines ? props.ingredientLines.map((ing) => { return <p>{ing}</p> }) : ""}
                                </div>
                            </div>

                            <div tabIndex={0} className="collapse collapse-arrow  border border-base-300 bg-base-100 rounded-box w-full max-w-xs">
                                <div className="collapse-title text-xl font-medium">
                                    Nutrients:
                                </div>
                                <div className="collapse-content">
                                    {props.nutrients ? Object.entries(props.nutrients).map((prop) => { return <> <p>{prop[0]}: </p><p>{parseInt(prop[1]).toFixed(2)} </p> </> }) : ""}
                                </div>
                            </div>
                            <div className="w-full">
                                {props.labels ? props.labels.map((ing) => { return <div className="badge badge-secondary badge-outline">{ing}{props.labels} </div> }) : ""}
                            </div>
                            <div className="w-full space-x-10">
                                {/* A button to save recipe */}
                                <label htmlFor="my-modal-4" className="btn glass  justify-start">Save Recipie</label>
                                {/* The button to open modal */}
                                <label htmlFor="my-modal-4" className="btn glass">To Recipie</label>
                            </div>
                        </div>
                    </div>
                </div>
            </th>
            <input type="checkbox" id="my-modal-4" className="modal-toggle" />
            <label htmlFor="my-modal-4" className="modal cursor-pointer">
                <label className="modal-box relative" htmlFor="">
                    <h3 className="text-lg font-bold">Welcome to Recipes</h3>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                    <p className="py-4">You've been selected for a chance to get one year of subscription to use Wikipedia for free!</p>
                </label>
            </label>
        </>
    );
};
