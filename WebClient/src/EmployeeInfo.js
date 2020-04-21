import React, { useState, Fragment, useEffect, useCallback } from 'react';
import { useSelector, useDispatch } from 'react-redux';
import { useGetList, useGetOne, Loading, Error, usePermissions } from 'react-admin';
import Select from '@material-ui/core/Select';
import MenuItem from '@material-ui/core/MenuItem';
import { changeShop } from './actions'

const EmployeeInfo = () => {
    const { loading, permissions } = usePermissions();
    const dispatch = useDispatch();
    useEffect(() => {
        dispatch(changeShop(1))
        // if (!loading) {
        //     dispatch(changeShop(permissions.shop))
        // }
    });

    return null;
};

export default EmployeeInfo;
